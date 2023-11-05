﻿namespace DataAccesLayer.Interface
{
    public interface IDAL_FuncionesExtras
    {
        //Listados

        //Chequeos
        bool existeCategoria(string nombre);
        bool existeCliente(string telefono);
        bool existeIngrediente(string nombre);
        bool existeClienteId(int id);
        bool existeMesa(int id_Mesa);
        bool existeProducto(string nombre);
        bool existePedido(int id);
        bool existeUsuario(string username);
        bool mesaEnUso(int idMesa);
        void agregarPrecioaMesa(float valor, int idMesa);
        void restarSaldoCliente(float valor, int idCliente);
    }
}
