## 3MLIDTS - CamilaChiu-03Python
### Formulario de registro
## almacenamiento de TXT sin validación

import tkinter as tk
from tkinter import messagebox


def limpiar_campos():
    tbNombre.delete(0, tk.END)
    tbApellidos.delete(0, tk.END)
    tbEdad.delete(0, tk.END)
    tbEstatura.delete(0, tk.END)
    tbTelefono.delete(0, tk.END)
    var_genero.set(0)
    tbTelefono.config(fg="black") 

def borrar_fun():
    limpiar_campos()

def validar_telefono(event):
    telefono = tbTelefono.get()
    if len(telefono) == 10 and telefono.isdigit():
        tbTelefono.config(fg="green")  
    elif len(telefono) > 10 or not telefono.isdigit():
        tbTelefono.config(fg="red") 
        
def evitar_cambio(event):
    telefono = tbTelefono.get()
    if len(telefono) != 10 or not telefono.isdigit():
        tbTelefono.config(fg="red")
        messagebox.showerror("Error de validación", "El teléfono debe tener exactamente 10 dígitos numéricos.")
        tbTelefono.focus_set()
        
def guardar_valores():
    nombres = tbNombre.get()
    apellidos = tbApellidos.get()
    edad = tbEdad.get()
    estatura = tbEstatura.get()
    telefono = tbTelefono.get()
    genero = ""
    
  
    if var_genero.get() == 1:
        genero = "Hombre"
    elif var_genero.get() == 2:
        genero = "Mujer"
    
    datos = f"Nombres: {nombres}\nApellidos: {apellidos}\nEdad: {edad}\nEstatura: {estatura}\nTeléfono: {telefono}\nGénero: {genero}\n"
    
    with open("Registro.txt", "a") as archivo:
        archivo.write(datos + "\n\n")
        
    messagebox.showinfo("Datos Guardados", "Los datos han sido guardados exitosamente.")
    limpiar_campos()


ventana = tk.Tk()
ventana.geometry("520x500")
ventana.title("Formulario vr.01")


var_genero = tk.IntVar()


tk.Label(ventana, text="Nombres:").pack()
tbNombre = tk.Entry(ventana)
tbNombre.pack()

tk.Label(ventana, text="Apellidos:").pack()
tbApellidos = tk.Entry(ventana)
tbApellidos.pack()

tk.Label(ventana, text="Edad:").pack()
tbEdad = tk.Entry(ventana)
tbEdad.pack()

tk.Label(ventana, text="Teléfono:").pack()
tbTelefono = tk.Entry(ventana)
tbTelefono.pack()


tbTelefono.bind('<KeyRelease>', validar_telefono)
tbTelefono.bind('<FocusOut>', evitar_cambio)

tk.Label(ventana, text="Estatura:").pack()
tbEstatura = tk.Entry(ventana)
tbEstatura.pack()

tk.Label(ventana, text="Género:").pack()
rbHombre = tk.Radiobutton(ventana, text="Hombre", variable=var_genero, value=1)
rbHombre.pack()
rbMujer = tk.Radiobutton(ventana, text="Mujer", variable=var_genero, value=2)
rbMujer.pack()


btnBorrar = tk.Button(ventana, text="Borrar", command=borrar_fun)
btnBorrar.pack()

btnGuardar = tk.Button(ventana, text="Guardar", command=guardar_valores)
btnGuardar.pack()


ventana.mainloop()