/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.ingesoft.rmi;

import java.rmi.Naming;
import java.rmi.registry.LocateRegistry;
import pe.edu.pucp.ingesoft.MySQL.CursoMySQL;
import pe.edu.pucp.ingesoft.MySQL.EspecialidadMySQL;
import pe.edu.pucp.ingesoft.dao.CursoDAO;
import pe.edu.pucp.ingesoft.dao.EspecialidadDAO;

/**
 *
 * @author joham
 */
public class Servidor {
    private static String puerto = "1234";
    private static String IP = "127.0.0.1";
    
    public static void main(String[]args){
        try{
            System.setProperty("java.remi.server.hostname", IP);
            LocateRegistry.createRegistry(Integer.parseInt(puerto));
            //Creamos las instancias de los objetos remotos
            CursoDAO objDAOCurso = new CursoMySQL(Integer.parseInt(puerto));
            EspecialidadDAO objDAOEspecialidad = new EspecialidadMySQL(Integer.parseInt(puerto));
            //Hacemos los obejtos disponibles de forma remota
            Naming.rebind("//"+IP+":"+puerto+"/"+"daoCurso",objDAOCurso);
            Naming.rebind("//"+IP+":"+puerto+"/"+"daoEspecialidad",objDAOEspecialidad);
            
            System.out.println("El servidor se ha inicializado correctamente...");
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    
}
