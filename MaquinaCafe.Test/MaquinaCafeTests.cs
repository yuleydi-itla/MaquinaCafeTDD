using NUnit.Framework;
using System;

namespace MaquinaCafe.Tests
{
    [TestFixture]
    public class MaquinaCafeTests
    {
        private MaquinaCafeApp.MaquinaCafe _maquina;

        [SetUp]
        public void Inicializar() => _maquina = new MaquinaCafeApp.MaquinaCafe();

        // TC-01
        [Test]
        public void InsertarMoneda_DebeAcumularSaldo()
        {
            _maquina.InsertarMoneda(25);
            Assert.AreEqual(25, _maquina.Saldo);
        }

        // TC-02
        [Test]
        public void SeleccionarBebida_SaldoSuficiente_RetornaTrue()
        {
            _maquina.InsertarMoneda(100);
            Assert.IsTrue(_maquina.SeleccionarBebida("Cafe"));
        }

        // TC-03
        [Test]
        public void SeleccionarBebida_SaldoInsuficiente_RetornaFalse()
        {
            _maquina.InsertarMoneda(50);
            Assert.IsFalse(_maquina.SeleccionarBebida("Cafe"));
        }

        // TC-04
        [Test]
        public void ObtenerCambio_DespuesDeDispensar_RetornaCambioCorrecto()
        {
            _maquina.InsertarMoneda(150);
            _maquina.SeleccionarBebida("Cafe");
            Assert.AreEqual(50, _maquina.ObtenerCambio());
        }

        // TC-05
        [Test]
        public void SeleccionarBebida_BebidaInexistente_LanzaExcepcion()
        {
            Assert.Throws<ArgumentException>(() => _maquina.SeleccionarBebida("Jugo"));
        }

        // TC-06
        [Test]
        public void ObtenerMenu_DebeRetornarTresBebidasConPrecios()
        {
            var menu = _maquina.ObtenerMenu();
            Assert.AreEqual(3, menu.Count);
        }

        // TC-07
        [Test]
        public void DevolverMonedas_DebeReiniciarSaldoACero()
        {
            _maquina.InsertarMoneda(100);
            _maquina.DevolverMonedas();
            Assert.AreEqual(0, _maquina.Saldo);
        }

        // TC-08
        [Test]
        public void SeleccionarBebida_SinStock_RetornaFalse()
        {
            for (int i = 0; i < 10; i++)
            {
                _maquina.InsertarMoneda(100);
                _maquina.SeleccionarBebida("Cafe");
            }
            _maquina.InsertarMoneda(100);
            Assert.IsFalse(_maquina.SeleccionarBebida("Cafe"));
        }
    }
}