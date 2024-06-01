/*
 * Creado por SharpDevelop.
 * Usuario: nico_
 * Fecha: 28/5/2024
 * Hora: 23:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Proyecto
{
	public class Empresa
	{
		//Atributos
		private ArrayList listaObras;
		private ArrayList listaObrasFin;
		private ArrayList listaObreros;
		private ArrayList grupos;
		
		//Constructor
		public Empresa()
		{
			listaObras = new ArrayList();
			listaObrasFin = new ArrayList();
			listaObreros = new ArrayList();
			grupos = new ArrayList();
		}
		
		//Metodos
		public void AgregarObra(Obra o)
		{listaObras.Add(o);}
		
		public void EliminarObra(Obra ob)
		{listaObras.Remove(ob);}
		
		public void AgregarObraFin(Obra o)
		{listaObrasFin.Add(o);}
		
		public void EliminarObraFin(Obra ob)
		{listaObrasFin.Remove(ob);}
		
		public void AgregarObrero(Obrero o)
		{listaObreros.Add(o);}
		
		public void ELiminarObrero(Obrero ob)
		{listaObreros.Remove(ob);}
		
		public void AgregarGrupo(Grupo g)
		{grupos.Add(g);}
		
		public void EliminarGrupo(Grupo g)
		{grupos.Remove(g);}
		
		public ArrayList TodasObras()
		{return listaObras;}
		
		public ArrayList TodasObrasFin()
		{return listaObrasFin;}
		
		public ArrayList TodosObreros()
		{return listaObreros;}
		
		public ArrayList TodosGrupos()
		{return grupos;}
		
		public int CantidadObras()
		{return listaObras.Count;}
		
		public int CantidadObrasFen()
		{return listaObrasFin.Count;}
		
		public int CantidadObreros()
		{return listaObreros.Count;}
		
		public int CantidadGrupos()
		{return grupos.Count;}
	}
}
