/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.ingesoft.dao;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.ArrayList;
import pe.edu.pucp.ingesoft.model.Especialidad;

/**
 *
 * @author joham
 */
public interface EspecialidadDAO extends Remote{
    public ArrayList<Especialidad> listarTodas()throws RemoteException;
}
