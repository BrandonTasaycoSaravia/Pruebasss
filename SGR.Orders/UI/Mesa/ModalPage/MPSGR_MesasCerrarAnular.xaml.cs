﻿/*********************************************************
'* CREADO POR	 : COMPUTER SYSTEMS SOLUTION
'*				   ABEL QUISPE ORELLANA
'* FCH. CREACIÓN : 26/12/2016
**********************************************************/
namespace SGR.Orders.UI.Mesa.ModalPage
{
    using ComputerSystems.WPF.Acciones.Controles.ModalDialog;
    using SGR.ViewModels.Orders.Mesa.Pages;
    using System.Windows.Controls;

    public partial class MPSGR_MesasCerrarAnular: CmpModalPage
    {
        public MPSGR_MesasCerrarAnular()
        {
            InitializeComponent();
            DataContext = new VMSGR_MesasCerrarAnular();
        }
    }
}
