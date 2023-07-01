/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package pe.edu.pucp.ingesoft.services;

import java.rmi.Naming;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ingesoft.dao.CursoDAO;
import pe.edu.pucp.ingesoft.dao.EspecialidadDAO;
import pe.edu.pucp.ingesoft.model.Especialidad;
import pe.edu.pucp.ingesoft.model.Curso;

/**
 *
 * @author joham
 */
@WebService(serviceName = "ServiceWS")
public class ServiceWS {
    private EspecialidadDAO objDAOEspecialidad;
    private CursoDAO cursoDao;
    
    public ServiceWS() {
        String IP = "127.0.0.1";
        String puerto = "1234";
        System.setProperty("java.rmi.server.hostname","127.0.0.1");
        
        try{
            cursoDao = (CursoDAO) Naming.lookup("//" + IP+ ":" + puerto + "/"+"daoCurso");
            //System.out.println("Curso Dao: "+cursoDao);
            objDAOEspecialidad = (EspecialidadDAO) Naming.lookup("//" + IP+ ":" + puerto + "/"+"daoEspecialidad");
            //System.out.println("Especialidad Dao: "+especialidadDao);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    /**
     * This is a sample web service operation
     * @return 
     */
    @WebMethod(operationName="ListarTodasEspecialidades")
    public ArrayList<Especialidad> ListarTodasEspecialidades(){
        ArrayList<Especialidad> especialidades = new ArrayList<>();
        try{
            especialidades=objDAOEspecialidad.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return especialidades;
    }
    
    @WebMethod(operationName="ListarCursoPorNombre")
    public ArrayList<Curso> ListarCursoPorNombre(String nombre){
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
            cursos=cursoDao.listarCursosPorNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return cursos;
    }
    
    @WebMethod(operationName="InsertarCurso")
    public int InsertarCurso(Curso curso){
        int resultado=0;
        try{
            resultado=cursoDao.insertarCurso(curso);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
}
