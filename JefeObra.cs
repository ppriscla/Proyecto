/*
 * Creado por SharpDevelop.
 * Usuario: nico_
 * Fecha: 28/5/2024
 * Hora: 23:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto
{
	public class JefeObra:Obrero
	{
		//Atributos de jefe de obra
		private int numeroObra, numeroGrupo;
		private double bonficacion;
		
		//Constructor
		public JefeObra(string nombreObrero, int dni, int nroLegajo, double sueldo, string cargo, int numeroObra, int numeroGrupo, double bonificacion): base(nombreObrero,dni,nroLegajo,sueldo,cargo)
		{
			this.numeroObra = numeroObra;
			this.numeroGrupo = numeroGrupo;
			this.bonficacion = bonificacion;
		}
		
		//Metodos
		public int NroObra
		{
			set{numeroObra = value;}
			get{return numeroObra;}
		}
		
		public int NroGrupo
		{
			set{numeroGrupo = value;}
			get{return numeroGrupo;}
		}
		
		public double Bonificacion
		{
			set{bonficacion = value;}
			get{return bonficacion;}
		}
	}
}
