using Fluxus.Core.Models;
using Fluxus.Core.Enums;
using Microsoft.Extensions.DependencyInjection;
using Fluxus.UseCases;

namespace Fluxus.WinUI.View
{
    public partial class uctAddService : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private readonly long _id;
        private EMethod _method;
        private IServiceProvider _serviceProvider;

        public uctAddService(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _frmPrincipal = frm1;
            _method = EMethod.Insert;
        }

        public uctAddService(frmMain frm1, Service service, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _frmPrincipal = frm1;
            _method = EMethod.Update;

            _id = service.Id;
            txtCodigo.Text = service.Tag;
            txtDescricao.Text = service.Description;
            txtValor.Text = service.ServiceAmount.ToString();
            txtDeslocamento.Text = service.MileageAllowance.ToString();
        }

        private void frmAddAtividade_Load(object sender, EventArgs e)
        {
            if (_method == EMethod.Update)
            {
                btnAddSave.Text = "&Salvar";
                txtCodigo.Enabled = false;
                txtDescricao.Focus();
            }
            else
                txtCodigo.Focus();
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            var serviceService = _serviceProvider.GetService<ServiceUseCases>();
            
            var service = PopulateObject();

            dynamic result = _method == EMethod.Insert ? serviceService.Insert(service) : serviceService.Update(service);

            if (result.Success)
                btnCancelar_Click(sender, e);
            else
                MessageBox.Show(result.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            uctService formFilho = new uctService(_frmPrincipal, _serviceProvider);
            _frmPrincipal.OpenUserControl(formFilho);
        }

        private Service PopulateObject()
        {
            var service = new Service
            (
                id : _id,
                tag : txtCodigo.Text,
                description : txtDescricao.Text,
                serviceAmount : Convert.ToDouble(txtValor.Text),
                mileageAllowance : Convert.ToDouble(txtDeslocamento.Text)
            );
            return service;
        }

    }


}
