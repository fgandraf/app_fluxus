﻿using Fluxus.App;
using Fluxus.App.Application;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Enums;
using Fluxus.Domain.Interfaces;
using Fluxus.Infra.Repositories;

namespace Fluxus.WinUI.View
{
    public partial class uctAddService : UserControl
    {
        private readonly frmMain _frmPrincipal;
        private readonly int _id;
        private EnumMethod _method;
        private IServiceRepository _serviceRepository;

        public uctAddService(frmMain frm1)
        {
            InitializeComponent();
            _frmPrincipal = frm1;
            _method = EnumMethod.Insert;
            _serviceRepository = new ServiceRepository();
        }

        public uctAddService(frmMain frm1, Service service)
        {
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
            var service = new ServiceService(_serviceRepository);
            service.Service = PopulateObject();

            var success = service.Execute(_method);

            if (success > 0)
                btnCancelar_Click(sender, e);
            else
                MessageBox.Show(service.Message, "Fluxus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            uctService formFilho = new uctService(_frmPrincipal);
            _frmPrincipal.OpenUserControl(formFilho);
        }

        private Service PopulateObject()
        {
            Service service = new Service
            {
                Id = _id,
                Tag = txtCodigo.Text,
                Description = txtDescricao.Text,
                ServiceAmount = txtValor.Text.Replace(',', '.'),
                MileageAllowance = txtDeslocamento.Text.Replace(',', '.')
            };
            return service;
        }

    }


}
