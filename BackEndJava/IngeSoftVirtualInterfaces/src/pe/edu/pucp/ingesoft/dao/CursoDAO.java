/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.ingesoft.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.ingesoft.model.Curso;

/**
 *
 * @author joham
 */
public interface CursoDAO extends Remote { 
    public ArrayList<Curso> listarCursosPorNombre(String nombre) throws RemoteException;
    public int insertarCurso(Curso curso) throws RemoteException;
}
