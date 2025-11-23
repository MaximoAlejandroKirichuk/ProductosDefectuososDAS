using System.Windows.Forms;
using Servicios;
using BE;                 // <--- Para reconocer IIdioma
using BE.ObserverIdioma;
using System.Globalization;

namespace UI
{
    // Hereda de Form e implementa IObservadorIdioma
    public partial class BaseForm : Form, IObservadorIdioma
    {
        public BaseForm()
        {
            // Validación robusta de modo diseño
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;

            LanguageManager.Instance.Suscribir(this);
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            LanguageManager.Instance.Desuscribir(this);
        }

    
        public void ActualizarIdioma(IIdioma idioma)
        {
            // A. Traducir el título de la ventana (si tiene Tag)
            if (this.Tag != null)
            {
                string traduccion = ObtenerTraduccion(this.Tag.ToString(), idioma);
                if (!string.IsNullOrEmpty(traduccion))
                {
                    this.Text = traduccion;
                }
            }

            // B. Traducir todos los controles internos
            RecorrerControles(this.Controls, idioma);
        }

        private void RecorrerControles(Control.ControlCollection controls, IIdioma idioma)
        {
            foreach (Control c in controls)
            {
                // Paso 1: Si tiene TAG, intentamos traducir
                if (c.Tag != null)
                {
                    string traduccion = ObtenerTraduccion(c.Tag.ToString(), idioma);

                    // Si encontramos traducción, cambiamos el texto
                    if (!string.IsNullOrEmpty(traduccion))
                    {
                        c.Text = traduccion;
                    }
                }

                // Paso 2: Si el control es un contenedor (Panel, GroupBox), entramos dentro
                if (c.HasChildren)
                {
                    RecorrerControles(c.Controls, idioma);
                }
            }
        }

        // --- 3. MÉTODO QUE BUSCA EN EL ARCHIVO RESX ---
        private string ObtenerTraduccion(string clave, IIdioma idioma)
        {
            // Validamos que haya idioma e ID
            if (idioma == null || string.IsNullOrEmpty(idioma.Id)) return null;

            // Creamos la cultura
            CultureInfo cultura = new CultureInfo(idioma.Id);

            // CORRECCIÓN AQUÍ:
            // 1. Asegúrate de que el namespace "UI.Idiomas" coincide con el del paso 2.
            // 2. Agrega ".ResourceManager" al final.
            System.Resources.ResourceManager manager = _0_ProyectoDAS.Idiomas.Res.ResourceManager;
            return manager.GetString(clave, cultura);
        }
        // Para asegurar que al abrirse tome el idioma actual
        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            // Si el LanguageManager ya tiene un idioma cargado, lo aplicamos al iniciar
            if (LanguageManager.Instance.IdiomaActual != null)
            {
                ActualizarIdioma(LanguageManager.Instance.IdiomaActual);
            }
        }
    }
}