using Fluxus.App.Services;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace Fluxus.WinUI.View
{
    public partial class uctAddService : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private readonly int _id;
        private EnumMethod _method;
        private IServiceProvider _serviceProvider;

        public uctAddService(frmMain frm1, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _frmPrincipal = frm1;
            _method = EnumMethod.Insert;
        }

        public uctAddService(frmMain frm1, Service service, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            _frmPrincipal = frm1;
            _method = EnumMethod.Update;

            _id = service.Id;
            txtCodigo.Text = service.Tag;
            txtDescricao.Text = service.Description;
            txtValor.Text = service.ServiceAmount;
            txtDeslocamento.Text = service.MileageAllowance;
        }

        private void frmAddAtividade_Load(object sender, EventArgs e)
        {
            if (_method == EnumMethod.Update)
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
            var serviceService = _serviceProvider.GetService<ServiceService>();
            
            var service = PopulateObject();

            dynamic result = _method == EnumMethod.Insert ? serviceService.Insert(service) : serviceService.Update(service);

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
            Service service = new Service
            (
                id : _id,
                tag : txtCodigo.Text,
                description : txtDescricao.Text,
                serviceAmount : txtValor.Text.Replace(',', '.'),
                mileageAllowance : txtDeslocamento.Text.Replace(',', '.')
            );
            return service;
        }

    }


}
