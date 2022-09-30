using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    public class Material
    {
        public int codigo_material { get; set; }
        public int cantidad { get; set; }
        public int cod_unidad_medida { get; set; }
        public int cod_proveedor {get; set; }
        public DateTime fecha_ingreso {get; set; }
        public float precio { get; set; }

        public Material(int codigo_material, int cantidad, int cod_unidad_medida, int cod_proveedor, DateTime fecha_ingreso, float precio)
        {
            this.codigo_material = codigo_material;
            this.cantidad = cantidad;
            this.cod_unidad_medida = cod_unidad_medida;
            this.cod_proveedor = cod_proveedor;
            this.fecha_ingreso = fecha_ingreso;
            this.precio = precio;
        }
        public Material()
        {

        }
    }
}
