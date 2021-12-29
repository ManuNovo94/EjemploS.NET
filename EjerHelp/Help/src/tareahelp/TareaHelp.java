/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tareahelp;

import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.net.MalformedURLException;
import java.net.URL;
import javax.help.HelpBroker;
import javax.help.HelpSet;
import javax.help.HelpSetException;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.WindowConstants;

/**
 *
 * @author Andres
 */
public class TareaHelp {

	/** Ventana principal */
	private JFrame principal;

	/** Boton que despliega la ventana de ayuda */
	private JButton botonMuestraAyuda;

	/**
	 * Crea una instanacia de esta clase.
	 * 
	 * @param args
	 */
	public static void main(String[] args) {
		new TareaHelp();
	}

	/**
	 * Crea las ventanas, pone la ayuda y visualiza la ventana principal.
	 */
	public TareaHelp() {
		creaVentanaPrincipal();

		botonMuestraAyuda.addActionListener((ActionEvent e) -> {
                });

		ponLaAyuda();
		visualizaVentanaPrincipal();
	}

	/**
	 * Con este nombre digo yo que visualizar· la ventana principal.
	 */
	private void visualizaVentanaPrincipal() {
		principal.pack();
		principal.setVisible(true);
		principal.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
	}

	/**
	 * Hace que el item del menu y la pulsacion de F1 visualicen la ayuda.
	 */
	private void ponLaAyuda() {
		try {
			// Carga el fichero de ayuda
			File fichero = new File("./help/help_set.hs");
			URL hsURL = fichero.toURI().toURL();

			// Crea el HelpSet y el HelpBroker
			HelpSet helpset = new HelpSet(getClass().getClassLoader(), hsURL);
			HelpBroker hb = helpset.createHelpBroker();

			// Pone ayuda al pulsar el botón y a F1 en la ventana.
			hb.enableHelpOnButton(botonMuestraAyuda, "aplicacion", helpset);
			hb.enableHelpKey(principal.getContentPane(), "aplicacion",helpset);

		} catch (IllegalArgumentException | MalformedURLException | HelpSetException e) {
		}
	}

	/**
	 * øQuiz·s crea la ventana principal?
	 */
	private void creaVentanaPrincipal() {
		principal = new JFrame("Tarea Ayuda");

		botonMuestraAyuda = new JButton("Muestra la ayuda");

		principal.getContentPane().setLayout(new FlowLayout());
		principal.getContentPane().add(botonMuestraAyuda);

	}

}
