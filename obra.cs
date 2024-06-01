/*
 * Creado por SharpDevelop.
 * Usuario: nico_
 * Fecha: 28/5/2024
 * Hora: 23:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto
{
	public class Obra
	{
		//Atributos
		private string nombrePro, tipoObra;
		private int dniProp, dniJefeObra, codigoObra, estadoAvance;
		private double costo;
		
		public Obra(string nombrePro, int dniProp, int codigoObra, string tipoObra, int estadoAvance, int dniJefeObra, double costo)
		{
			this.nombrePro = nombrePro;
			this.dniProp = dniProp;
			this.codigoObra = codigoObra;
			this.tipoObra = tipoObra;
			this.estadoAvance = estadoAvance;
			this.dniJefeObra = dniJefeObra;
			this.costo = costo;
		}
		
		//Metodos
		public string NombreProp
		{ get{return nombrePro;} }
		
		public int DniPro
		{ get{return dniProp;} }
		
		public int CodigoObra
		{ get{return codigoObra;} }
		
		public string TipoObra
		{
			set{tipoObra = value;}
			get{return tipoObra;}
		}
		
		public int EstadoAvance
		{ 
			set{estadoAvance = value;}
			get{return estadoAvance;}
		}
		
		public int DniJefObra
		{
			set{dniJefeObra = value;}
			get{return dniJefeObra;}
		}
		
		public double Costo
		{
			set{costo = value;}
			get{return costo;}
		}
	}
}
