using InteractuarOutlook.Modelos;
using Microsoft.Office.Interop.Outlook;
using Application = Microsoft.Office.Interop.Outlook.Application;
using Exception = System.Exception;

namespace InteractuarOutlook {
    public partial class Form1 : Form {
        #region Variables
        string emisorFiltro, receptorFiltro, asuntoFiltro;
        DateTime fechaInicioFiltro, fechaFinalFiltro;
        List<Email> todosLosEmails;
        private Dictionary<string, Color> coloresPorCuenta = new Dictionary<string, Color>();
        private List<Color> coloresDisponibles = new List<Color> {
            Color.LightBlue, Color.LightGreen, Color.LightCoral,
            Color.LightGoldenrodYellow, Color.LightPink, // etc., una lista de colores predefinidos
        };
        private int indiceColorActual = 0;
        #endregion
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dtpFechaInicioFiltro.Value = DateTime.Now.AddDays(-364);
            dtpFechaFinalFiltro.Value = DateTime.Now;
            todosLosEmails = LeerCorreos();
            dgBandejaEmail.DataSource = todosLosEmails;
            dgBandejaEmailEstilo();
            aplicarFiltro();
        }

        private void dgBandejaEmailEstilo() {
            if (dgBandejaEmail.Columns["EmailEmisor"] != null) {
                dgBandejaEmail.Columns["EmailEmisor"].Visible = false;
            }
            if (dgBandejaEmail.Columns["Cuerpo"] != null) {
                dgBandejaEmail.Columns["Cuerpo"].Visible = false;
            }
            if (dgBandejaEmail.Columns["Cuenta"] != null) {
                dgBandejaEmail.Columns["Cuenta"].Visible = false;
            }
        }
        // Leemos los correos del outlook
        private List<Email> LeerCorreos() {
            todosLosEmails = new List<Email>();
            Application outlookApp = new Application();
            NameSpace outlookNamespace = outlookApp.GetNamespace("MAPI");

            cbBandejasEntrada.Items.Clear(); // Limpia el ComboBox antes de cargar nuevos elementos
            cbBandejasEntrada.Items.Add("Todos");
            foreach (Store store in outlookNamespace.Stores) {
                string cuentaCorreo = store.DisplayName; // O alguna otra propiedad que identifique la cuenta
                // Añadir la cuenta al ComboBox
                cbBandejasEntrada.Items.Add(cuentaCorreo);
                MAPIFolder bandejaEntrada = store.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
                LeerCorreosDeCarpeta(bandejaEntrada, "", "Recibido", cuentaCorreo); // Pasar la cuenta como parámetro
                MAPIFolder bandejaEnviados = store.GetDefaultFolder(OlDefaultFolders.olFolderSentMail);
                LeerCorreosDeCarpeta(bandejaEnviados, "", "Enviado", cuentaCorreo); // Pasar la cuenta como parámetro
            }
            return todosLosEmails.OrderByDescending(email => DateTime.Parse(email.FechaRecibo)).ToList();
        }

        // Leemos los correos pero escudriñando las carpetas
        private void LeerCorreosDeCarpeta(MAPIFolder carpeta, string rutaCarpeta, string esEnviado, string cuentaCorreo) {
            Items mailItems = carpeta.Items;
            foreach (object item in mailItems) {
                if (item is MailItem mail) {
                    todosLosEmails.Add(new Email {
                        Emisor = mail.SenderName,
                        EmailEmisor = mail.SenderEmailAddress,
                        Receptor = mail.To,
                        Cuerpo = mail.Body,
                        Asunto = mail.Subject,
                        FechaRecibo = mail.ReceivedTime.ToString(),
                        Carpeta = rutaCarpeta + carpeta.Name,
                        Enviado = esEnviado,
                        Cuenta = cuentaCorreo
                    });
                }
            }
            // Recursividad para subcarpetas
            foreach (MAPIFolder subCarpeta in carpeta.Folders) {
                LeerCorreosDeCarpeta(subCarpeta, rutaCarpeta + carpeta.Name + "/", esEnviado, cuentaCorreo);
            }
        }
        private void btnAceptarFiltro_Click(object sender, EventArgs e) {
            aplicarFiltro();
        }

        private void aplicarFiltro() {
            IEnumerable<Email> correosFiltrados = todosLosEmails;
            string filtroEmisor = txtEmisorFiltro.Text.ToLower();
            string filtroReceptor = txtReceptorFiltro.Text.ToLower();
            string filtroAsunto = txtAsuntosFiltro.Text.ToLower();
            string filtroCuerpo = txtCuerpoFiltro.Text.ToLower();
            DateTime fechaInicio = dtpFechaInicioFiltro.Value.Date;
            DateTime fechaFin = dtpFechaFinalFiltro.Value.Date.AddDays(1);

            if (!string.IsNullOrWhiteSpace(filtroEmisor)) {
                correosFiltrados = correosFiltrados.Where(email =>
                    !string.IsNullOrEmpty(email.EmailEmisor) &&
                    email.EmailEmisor.ToLower().Contains(filtroEmisor));
            }
            if (!string.IsNullOrWhiteSpace(filtroReceptor)) {
                correosFiltrados = correosFiltrados.Where(email =>
                    !string.IsNullOrEmpty(email.Receptor) &&
                    email.Receptor.ToLower().Contains(filtroReceptor));
            }
            if (!string.IsNullOrWhiteSpace(filtroAsunto)) {
                correosFiltrados = correosFiltrados.Where(email =>
                    !string.IsNullOrEmpty(email.Asunto) &&
                    email.Asunto.ToLower().Contains(filtroAsunto));
            }
            if (!string.IsNullOrWhiteSpace(filtroCuerpo)) {
                correosFiltrados = correosFiltrados.Where(email =>
                    !string.IsNullOrEmpty(email.Cuerpo) &&
                    email.Cuerpo.ToLower().Contains(filtroCuerpo));
            }
            if (cbBandejasEntrada.SelectedItem != null && cbBandejasEntrada.SelectedItem.ToString() != "Todos") {
                string cuentaSeleccionada = cbBandejasEntrada.SelectedItem.ToString();
                correosFiltrados = correosFiltrados.Where(email => email.Cuenta == cuentaSeleccionada);
            }
            //Filtrar por checkbox
            if (rdbEnviado.Checked) {
                correosFiltrados = correosFiltrados.Where(email => email.Enviado == "Enviado");
            } else if (rdbRecibido.Checked) { // Asegúrate de tener un RadioButton para correos recibidos
                correosFiltrados = correosFiltrados.Where(email => email.Enviado == "Recibido");
            }
            // Filtrar por fechas
            correosFiltrados = correosFiltrados.Where(email => {
                DateTime fechaRecibo = DateTime.Parse(email.FechaRecibo);
                return fechaRecibo >= fechaInicio && fechaRecibo < fechaFin;
            });
            dgBandejaEmail.DataSource = correosFiltrados.ToList();
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e) {
            // Limpiar cuadros de texto de filtro
            txtEmisorFiltro.Clear();
            txtReceptorFiltro.Clear();
            txtAsuntosFiltro.Clear();
            txtCuerpoFiltro.Clear();
            cbBandejasEntrada.SelectedIndex = 0;

            dtpFechaInicioFiltro.Value = DateTime.Now.AddDays(-364);
            dtpFechaFinalFiltro.Value = DateTime.Now;

            // Restablecer el DataSource del DataGridView
            dgBandejaEmail.DataSource = todosLosEmails;
            rdbRecibido.Checked = true;
            aplicarFiltro();
        }

        private void tbbResponderCorreoOutlook_Click(object sender, EventArgs e) {
            if (dgBandejaEmail.CurrentRow != null) {
                Email emailSeleccionado = dgBandejaEmail.CurrentRow.DataBoundItem as Email;
                if (emailSeleccionado != null) {
                    try {
                        Application outlookApp = new Application();
                        if (outlookApp == null)
                            throw new Exception("Outlook no está instalado o no se pudo abrir.");

                        NameSpace outlookNamespace = outlookApp.GetNamespace("MAPI");
                        MAPIFolder bandejaEntrada = outlookNamespace.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
                        Items itemsBandeja = bandejaEntrada.Items;

                        foreach (object item in itemsBandeja) {
                            if (item is MailItem mailItem) {
                                // Aquí comparamos para encontrar el correo específico
                                if (mailItem.Subject == emailSeleccionado.Asunto &&
                                    mailItem.SenderEmailAddress == emailSeleccionado.EmailEmisor &&
                                    mailItem.ReceivedTime.ToString() == emailSeleccionado.FechaRecibo) {
                                    // Encontramos el correo, ahora respondemos
                                    MailItem respuesta = mailItem.ReplyAll(); // Si quieres responder a todos aqui 
                                    //MailItem respuesta = mailItem.Reply(); // Si quieres responder solo a remitente original
                                    respuesta.Display(true);
                                    break;
                                }
                            }
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("Error al abrir Outlook: " + ex.Message);
                    }
                }
            }
        }

        private void dgBandejaEmail_CellClick(object sender, DataGridViewCellEventArgs e) {
            // Verifica que la fila seleccionada sea válida
            if (e.RowIndex >= 0 && e.RowIndex < dgBandejaEmail.Rows.Count) {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dgBandejaEmail.Rows[e.RowIndex];
                // Asegúrate de que la fila tenga datos
                if (filaSeleccionada.DataBoundItem is Email emailSeleccionado) {
                    // Asigna el cuerpo del correo al RichTextBox
                    rtbCuerpoCorreo.Text = emailSeleccionado.Cuerpo;
                }
            }
        }

        private Color ObtenerColorParaCuenta(string cuenta) {
            if (!coloresPorCuenta.ContainsKey(cuenta)) {
                Color colorAsignado = coloresDisponibles[indiceColorActual % coloresDisponibles.Count];
                coloresPorCuenta[cuenta] = colorAsignado;
                indiceColorActual++;
            }
            return coloresPorCuenta[cuenta];
        }

        private void dgBandejaEmail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.RowIndex >= 0) {
                Email email = dgBandejaEmail.Rows[e.RowIndex].DataBoundItem as Email;
                if (email != null) {
                    e.CellStyle.BackColor = ObtenerColorParaCuenta(email.Cuenta);
                }
            }
        }
    }
}