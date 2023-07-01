package pe.edu.pucp.rmi.interfaces;

import java.rmi.Remote;
import java.rmi.RemoteException;

/**
 *
 * @author joham
 */
public interface Interfaz extends Remote {
    public int sumar(int a,int b) throws RemoteException;
    
}
