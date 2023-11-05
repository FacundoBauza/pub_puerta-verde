﻿using BusinessLayer.Interfaces;
using Domain.DT;
using Domain.Entidades;
using Microsoft.AspNetCore.Mvc;
using WebApi_PUB_PV.Models;

namespace WebApi_PUB_PV.Controllers
{
    public class Productos_Ingredientes : Controller
    {

        private IBProductos_Ingredientes bl;
        public Productos_Ingredientes(IBProductos_Ingredientes _bl)
        {
            bl = _bl;
        }

        //Agregar
        [HttpPost("/api/agregarProductos_Ingredientes")]
        public ActionResult<DTProductos_Ingredientes> Post([FromBody] DTProductos_Ingredientes value)
        {
            MensajeRetorno x = bl.Productos_Ingredientes(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        //Quitar
        [HttpPost("/api/quitarProductos_Ingredientes")]
        public ActionResult<DTProductos_Ingredientes> Delete([FromBody] DTProductos_Ingredientes value)
        {
            MensajeRetorno x = bl.quitarProductos_Ingredientes(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        //Listar
        [HttpGet("/api/listarIngredientesProducto{idProducto}")]
        public List<DTIngrediente> Get(int idProducto)
        {
            return bl.listar_IngredientesProducto(idProducto);
        }
    }
}
