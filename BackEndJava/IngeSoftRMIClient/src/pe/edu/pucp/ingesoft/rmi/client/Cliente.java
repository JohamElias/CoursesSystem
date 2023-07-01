/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.ingesoft.rmi.client;

import java.rmi.Naming;
import java.util.ArrayList;
import pe.edu.pucp.ingesoft.dao.CursoDAO;
import pe.edu.pucp.ingesoft.dao.EspecialidadDAO;
import pe.edu.pucp.ingesoft.model.Curso;
import pe.edu.pucp.ingesoft.model.Especialidad;

/**
 *
 * @author joham
 */
public class Cliente {
    private static String puerto = "1234";
    private static String IP = "127.0.0.1";
    public static void main(String[] args){
        try{
            CursoDAO objDAOCurso = (CursoDAO)Naming.lookup("//"+IP+":"+puerto+"/"+"daoCurso");
            ArrayList<Curso> cursos=objDAOCurso.listarCursosPorNombre("");
            EspecialidadDAO objDAOEspecialidad = (EspecialidadDAO)Naming.lookup("//"+IP+":"+puerto+"/"+"daoEspecialidad");
            ArrayList<Especialidad> especialidades=objDAOEspecialidad.listarTodas();
            for(Especialidad e : especialidades){
                System.out.println(e.getIdEspecialidad()+". "+e.getNombre());
            }
            
        }catch(Exception ex){
                System.out.println(ex.getMessage());
        }
    }
}
