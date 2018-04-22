using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vueling.Presentation
{
    public partial class dataGridAlumnos : Form
    {
        private Alumno alumno;
        private HttpClient client;

        public dataGridAlumnos()
        {
            InitializeComponent();
            this.alumno = new Alumno();
            this.client = new HttpClient();
            this.InitHttpHeader();
        }

        private void InitHttpHeader()
        {
            client.BaseAddress = new Uri("http://localhost:52768/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.MostrarAlumnos(Task<List<Alumno>>.Run(LeerAsync).Result);
        }

        private async Task<List<Alumno>> LeerAsync()
        {
            var endpoint = $"api/Alumno/GetAllStudents";
            //envia la solicitud http get y obtiene un httpresponse con la respuesta http
            HttpResponseMessage response = await client.GetAsync(endpoint);
            //comprueba si el código de estado de la respuesta es correcto
            response.EnsureSuccessStatusCode();
            using (HttpContent content = response.Content)
            {
                //deserializa el json
                List<Alumno> alumnos = await response.Content.ReadAsAsync<List<Alumno>>();
                return alumnos;
            }
        }

        private void MostrarAlumnos(List<Alumno> alumnos)
        {
            this.dataGridListadoAlumnos.DataSource = alumnos;
            this.dataGridListadoAlumnos.Update();
        }
    }
}
