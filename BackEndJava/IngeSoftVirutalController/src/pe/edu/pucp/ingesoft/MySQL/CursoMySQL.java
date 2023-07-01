/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.ingesoft.MySQL;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.ingesoft.config.DBManager;
import pe.edu.pucp.ingesoft.dao.CursoDAO;
import pe.edu.pucp.ingesoft.model.Curso;
import pe.edu.pucp.ingesoft.model.Especialidad;

/**
 *
 * @author joham
 */
public class CursoMySQL extends UnicastRemoteObject implements CursoDAO {
    public CursoMySQL(int puerto)throws RemoteException{
        super(puerto);
    }
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public ArrayList<Curso> listarCursosPorNombre(String nombre)throws RemoteException {
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CURSOS_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Curso us = new Curso();
                us.setIdCurso(rs.getInt("id_curso"));
                us.setNombre(rs.getString("nombre_curso"));
                us.setClave(rs.getString("clave"));
                us.setPrecio(rs.getDouble("precio"));
                us.setActivo(true);
                us.setCreditos(rs.getInt("creditos"));
                us.setFechaFin(rs.getDate("fecha_fin"));
                us.setFechaInicio(rs.getDate("fecha_inicio"));
                us.setEspecialidad(new Especialidad());
                us.getEspecialidad().setIdEspecialidad(rs.getInt("id_especialidad"));
                us.getEspecialidad().setNombre(rs.getString("nombre_especialidad"));
                cursos.add(us);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return cursos;
    }

    @Override
    public int insertarCurso(Curso curso) throws RemoteException {
        int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CURSO(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_curso", 
                    java.sql.Types.INTEGER);
            cs.setInt("_fid_especialidad", curso.getEspecialidad().getIdEspecialidad());
            cs.setString("_nombre", curso.getNombre());
            cs.setDouble("_creditos", curso.getCreditos());
            cs.setDouble("_precio", curso.getPrecio());
            cs.setString("_clave", curso.getClave());
            cs.setDate("_fecha_inicio", new Date(curso.getFechaInicio().getTime()));
            cs.setDate("_fecha_fin", new Date(curso.getFechaFin().getTime()));
            //cs.setBoolean("_activo", true);
            cs.executeUpdate();
            curso.setIdCurso(cs.getInt("_id_curso"));
            System.out.println("Se inserto un usuario correctamente");
            resultado = curso.getIdCurso();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }
    
}
