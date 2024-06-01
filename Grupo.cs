/*
 * Creado por SharpDevelop.
 * Usuario: nico_
 * Fecha: 30/5/2024
 * Hora: 19:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Proyecto
{
	public class Grupo
	{
		private int nroObra;
		private JefeObra jefObra;
		private ArrayList listaIntegrantes;
		
		public Grupo(int nroObra, JefeObra jefObra)
		{
			this.nroObra = nroObra;
			this.jefObra = jefObra;
			listaIntegrantes = new ArrayList();
		}
		
		public int NroObra
		{
			set{nroObra = value;}
			get{return nroObra;}
		}
		
		public JefeObra JefObra
		{
			set{jefObra = value;}
			get{return jefObra;}
		}
		
		public void AgregarIntegrantes(Obrero o)
		{ listaIntegrantes.Add(o); }
		
		public void EliminarObrero(Obrero o)
		{ listaIntegrantes.Remove(o); }
		
		public ArrayList TodosIntegrantes()
		{return listaIntegrantes;}
	}
}
