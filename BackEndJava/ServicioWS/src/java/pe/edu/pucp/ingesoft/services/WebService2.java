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
import pe.edu.pucp.ingesoft.dao.EspecialidadDAO;
import pe.edu.pucp.ingesoft.model.Especialidad;

/**
 *
 * @author joham
 */
@WebService(serviceName = "WebService")
public class WebService2 {

    private static String puerto = "1234";
    private static String IP = "127.0.0.1";
//    try{
//            CursoDAO objDAOCurso = (CursoDAO)Naming.lookup("//"+IP+":"+puerto+"/"+"daoCurso");
//            EspecialidadDAO objDAOEspecialidad = (EspecialidadDAO)Naming.lookup("//"+IP+":"+puerto+"/"+"daoEspecialidad");
//        }catch(Exception ex){
//            System.out.println(ex.getMessage());
//        }
    
    
    
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
}
