/*
 * Creado por SharpDevelop.
 * Usuario: nico_
 * Fecha: 28/5/2024
 * Hora: 23:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto
{

	public class Obrero
	{
		//Atributos
		protected string nombreObrero, cargo;
		protected int dni, nroLegajo;
		protected double sueldo;
		
		//Constructor
		public Obrero(string nombreObrero, int dni, int nroLegajo, double sueldo, string cargo)
		{
			this.nombreObrero = nombreObrero;
			this.dni = dni;
			this.nroLegajo = nroLegajo;
			this.sueldo = sueldo;
			this.cargo = cargo;
		}
		
		//Metodos
		public string NombreObrero
		{
			set{nombreObrero = value;}
			get{return nombreObrero;}
		}
		
		public int Dni
		{ get{return dni;} }
		
		public int NroLegajo
		{ get{return nroLegajo;} }
		
		public double Sueldo
		{
			set{sueldo = value;}
			get{return sueldo;}
		}
		
		public string Cargo
		{
			set{cargo = value;}
			get{return cargo;}
		}
		
		
	}
}
