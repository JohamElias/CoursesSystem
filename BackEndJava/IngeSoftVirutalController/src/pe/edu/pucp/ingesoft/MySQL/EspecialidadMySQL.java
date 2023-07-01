/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.ingesoft.MySQL;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.ingesoft.config.DBManager;
import pe.edu.pucp.ingesoft.dao.EspecialidadDAO;
import pe.edu.pucp.ingesoft.model.Especialidad;

/**
 *
 * @author joham
 */
public class EspecialidadMySQL extends UnicastRemoteObject implements EspecialidadDAO {
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    public EspecialidadMySQL(int puerto)throws RemoteException{
        super(puerto);
    }

    @Override
    public ArrayList<Especialidad> listarTodas() throws RemoteException {
        ArrayList<Especialidad> especialidades = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_TODAS_ESPECIALIDADES()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Especialidad us = new Especialidad();
                us.setIdEspecialidad(rs.getInt("id_especialidad"));
                us.setNombre(rs.getString("nombre"));
                us.setActivo(true);
                especialidades.add(us);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return especialidades;
    }
}
