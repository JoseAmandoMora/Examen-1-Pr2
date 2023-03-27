using Evaluación_número_1_Jose_Mora;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Evaluación_número_1_Jose_Mora
{


    /// <summary>
    ///                                     UNIVERSIDAD DE LOS ANDES
    ///                                    DEPARTAMENTO DE COMPUTACIÓN
    //                                          PROGRAMACIÓN 2
    ///                                         SEMESTRE A-2023
    ///                                         
    //                                 ESTUDIANTE: José Amando Mora Rivas
    //                                     C.I   : 29.634.375
    /// 
    //                              Evaluación número 1 - Programación Orientada a Objetos
    /// </summary>
//                                             TuProductoOnline


    //          1)La representación de los productos del catálogo en el sistema 


    class PiezasDeHardware {

        //Atributos 
        private string _nombre; //1
        private string _precio;//2
        private string _marca;//3
        private string _descripcion;//4
        private string _capacidad;//5
        private string _color;//6
        //Property para Nombre
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        //Property para Precio
        public string Precio { get { return _precio; } set { _precio = value; } }
        //Property para Marca 
        public string Marca { get { return _marca; } set { _marca = value; } }
        //Property para Descripcion
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }

        //Constructor 
        //Property para  Capacidad
        public string Capacidad { get { return _capacidad; } set { _capacidad = value; } }
        //Property para Color
        public string Color { get { return _color; } set { _color = value; } }

        //Constructor Parametrico
        public PiezasDeHardware(string Nombre_Producto, string Precio_Producto, string Marca_Producto, string Descripcion_Producto, string Capacidad_Producto, string Color_Producto) {
            Nombre = Nombre_Producto;
            Precio = Precio_Producto;
            Marca = Marca_Producto;
            Descripcion = Descripcion_Producto;
            Capacidad = Capacidad_Producto;
            Color = Color_Producto;
        }
        public void imprimirEnlaclase(string Nombre, int Precio, string Marca, string Descripcion, string Capacidad, string Color)
        {
            Console.WriteLine($" {Nombre}|{Precio}|{Marca}|{Descripcion}|{Capacidad} |{Color}|");
        }
    }



    class EquiposTecnologicos
    {
        //  Atributos
        private string _nombre;//1
        private string _precio;//2
        private string _marca;//3
        private string _descripcion;//3
        private string _memoria;//4
        private string _color;//5
                              //Property para Nombre
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        //Property para Precio
        public string Precio { get { return _precio; } set { _precio = value; } }
        //Property para Marca 
        public string Marca { get { return _marca; } set { _marca = value; } }
        //Property para Descripcion
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }

        //Property para Color
        public string Color { get { return _color; } set { _color = value; } }
        //Property para Memoria
        public string Memoria { get { return _memoria; } set { _memoria = value; } }

        //  Metodos 
        public EquiposTecnologicos(string Nombre_Producto, string Precio_Producto, string Marca_Producto, string Descripcion_Producto, string Memoria_Producto, string Color_Producto)
        {
            Nombre = Nombre_Producto;
            Precio = Precio_Producto;
            Marca = Marca_Producto;
            Descripcion = Descripcion_Producto;
            Memoria = Memoria_Producto;
            Color = Color_Producto;

        }
        
        //muestra los datos del producto por pantalla  
        public void imprimirEnlaclase(string Nombre, int Precio, string Marca, string Descripcion, string Memoria, string Color)
        {
            Console.WriteLine($" {Nombre}|{Precio}|{Marca}|{Descripcion}|{Memoria} |{Color}|");

        }
    }



    class ProductosDeSoftware
    {
        //Atributos 
        private string _nombre;//1
        private string _precio;//2
        private string _marca;//3
        private string _descripcion;//4
        private string _memoria;//5
        private string _color;//6
        private string _idioma;//7
        private string _version;//8

        //Property para Nombre
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        //Property para Precio
        public string Precio { get { return _precio; } set { _precio = value; } }
        //Property para Marca 
        public string Marca { get { return _marca; } set { _marca = value; } }
        //Property para Descripcion
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }

        //Property para Color
        public string Color { get { return _color; } set { _color = value; } }
        //Property para Idioma
        public string Memoria { get { return _memoria; } set { _memoria = value; } }
        //Property para Idioma
        public string Idioma { get { return _idioma; } set { _idioma = value; } }
        //Property para Version
        public string Version { get { return _version; } set { _version = value; } }

        //constructor parametrico
        public ProductosDeSoftware(string Nombre_Producto, string Precio_Producto, string Marca_Producto, string Descripcion_Producto, string Memoria_Producto, string Idioma_Producto, string Version_Producto)
        {
            Nombre = Nombre_Producto;    //asignacion de atributos de venta en el sistema 
            Precio = Precio_Producto;
            Marca = Marca_Producto;
            Descripcion = Descripcion_Producto;
            Memoria = Memoria_Producto;
            Idioma = Idioma_Producto;
            Version = Version_Producto;
        }
        public void imprimirEnlaclase(string Nombre, string Precio, string Marca, string Descripcion, string Memoria, string Idioma ,string Version  )
        {
            Console.WriteLine($" {Nombre}|{Precio}|{Marca}|{Descripcion}|{Memoria} |{Idioma}|{Version}|");
        }

    }



    class  Menu //clase madre
    {
        //Atributos
        private string _categoriaDeArticulo; // el usario elijira la categoria donde quiere comprar 
        private int _articulo; // cantidad  articulos que ha comprado 
        private int _x;
        private string _comparadorDeCiclo; //para que el usuario continue o finalice la compra 
        private int _monto; //se guardara el monto del producto 
        private int _montoAnterior; // se guarda el monto del prodcto anterior a comprar
        private int _montoDespues;
        private string _compra; // compra que haga el usuario
        private string _descripcion; //datos del producto que ha comprado (carrito)
        private int _cantidadDeElementos; // cantidad de productos que ha comprado (carrito)

        //Propertys del Menu 

        public int MontoDespues { get { return _montoDespues; } set { _montoDespues = value; } }
        public int Monto { get { return _monto; } set { _monto = value; } }
        public int MontoAnterior { get { return _montoAnterior; } set { _montoAnterior = value; } }
        public string ComparadorDeCiclo { get { return _comparadorDeCiclo; } set { _comparadorDeCiclo = value; } }
        public string CategoriaDeArticulo { get { return _categoriaDeArticulo; } set { _categoriaDeArticulo = value; } }
        public int Articulo { get { return _articulo; } set { _articulo = value; } }

        //contructor parametrico
        public Menu()
        {
            _descripcion = "Ningun Producto";
            Articulo = 0;
            _cantidadDeElementos = 0;
            _x = 1;  //para el ciclo 
            Monto = 0;
            MontoAnterior = 0;
            MontoDespues = 0;
                            //para que no me afecte en una suma más adelante 
        }
  ///////////////////////////////////////////////////////////////////////
  ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  //Metodos de la clase Menu 
 //Funcion del menu en pantalla (Estetica)

        //        2)    Un menú que permita consultar la lista de artículos desde la consola, seleccionar artículos y finalizar la compra

        //metodos
        public void TuPoductoOline()
        {
            Console.WriteLine($"**********************|  Bienvenido a TuProductoOnline |*************************JoseMoraULA*A2023|\n|\n|\n|  Presione una tecla y enter para continuar ");
        }
        public int Menu_Program(string CategoriaDeArticulo)
        {
            //menu para que el usuario haga su compra
            do
            {     
                if (_x == 1)     //controlador si el ususario continua comprando
                {
                    Console.WriteLine($"|\n|******************************************************************************|");
                    Console.WriteLine($"|\n|_____________| *MENU* :Seleccione una categoria de productos |________________|\n|\n|      1)Piezas de Hardware\n|\n|\n|      2)Equipos Tecnológicos\n|\n|\n|      3)Productos de Software\n|\n|\n|Coloque el número de su opcion de Categoria :");
                    CategoriaDeArticulo = Console.ReadLine();
                    if (CategoriaDeArticulo == "1" || CategoriaDeArticulo == "2" || CategoriaDeArticulo == "3")
                    {
                        switch (CategoriaDeArticulo)
                        {//Tienda Piezas de Hardware
                            case "1":
                                Console.WriteLine("\n|__________| Tienda Piezas de Hardware |___________________|\n|              \n|  Producto         Precio en $|\n|\n| 1) Procesadores|          31$|\n| 2) Teclado|               13$|\n| 3) Mouse|                  8$|\n| 4) Disco duro|            30$|\n| 5) Tarjeta Madre|         90$|\n___________________________________________________________|\n|\n|       Seleccione el número del articulo a comprar : ");
                                _compra = Console.ReadLine();
                                if (_compra == "1")
                                {
                                    MontoDespues = 31; // Procesadores
                                    
                                    _descripcion = "( Procesador )  de costo 31$ ";//asignacion que tendra la funcion de LlenarDatos
                                    _cantidadDeElementos++;                     //control de la compra
                                   
                                }
                                else if (_compra == "2")
                                {
                                    MontoDespues = 13; //Teclado
                                    _descripcion = "( Teclado )  de costo 13$ ";    //asignacion que tendra la funcion de LlenarDatos
                                    _cantidadDeElementos++;                        //control de la compra
                                }
                                else if (_compra == "3")
                                {
                                    MontoDespues = 8;  //Mouse
                                    _descripcion = "( Mouse )  de costo 8$ ";   //asignacion que tendra la funcion de LlenarDatos
                                    _cantidadDeElementos++;                 //control de la compra
                                }
                                else if (_compra == "4")
                                {
                                    MontoDespues = 30; //Disco duro
                                    _descripcion = "( Disco duro )  de costo 30$ "; //asignacion que tendra la funcion de LlenarDatos
                                    _cantidadDeElementos++;                     //control de la compra
                                }
                                else if (_compra == "5")
                                {
                                    MontoDespues = 90; //Tarjeta Madre
                                    _descripcion = "( Tarjeta madre )  de costo 90$ ";  //asignacion que tendra la funcion de LlenarDatos
                                    _cantidadDeElementos++;                         //control de la compra
                                }
                                else
                                {
                                    Console.WriteLine($"|   Esa numero de producto no se encuentra   |\n");// si el usuario coloca el número un producto no valido
                                    Console.WriteLine($"|   Precione enter para terminar    |\n");
                                    Console.ReadLine();

                                }
                                break;
                            // Tienda Equipos Tecnologicos 
                            case "2":
                                Console.WriteLine("\n|__________| Tienda Equipos Tecnologicos |_________________|\n|              \n|  Producto             Precio en $|\n|\n| 1) Equipo de sonido|          20$|\n| 2) Modem|                     12$|\n| 3) USB (Pendrive)|             9$|\n| 4) Teléfono|                 120$|\n| 5) Computador|               200$|\n| 6) Smartwatch|                40$|\n| 7) Impresora|                100$|\n___________________________________________________________________________|\n|\n|       Seleccione el número del articulo a comprar : ");
                                _compra = Console.ReadLine();
                                if (_compra == "1")
                                {
                                    MontoDespues = 20; // _equipoDeSonido;
                                    _descripcion = "( Equipo de sonido ) de costo 20$ | maraca sonic | color rojo |";
                                    _cantidadDeElementos++;
                                }
                                else if (_compra == "2")
                                {
                                    MontoDespues = 12; //modem
                                    _descripcion = "( Modem )de costo 12$ |  maraca sin definir  | color negro |";
                                    _cantidadDeElementos++;
                                }
                                else if (_compra == "3")
                                {
                                    MontoDespues = 9;  //_usb(Pendrive)
                                    _descripcion = "( USB (Pendrive) ) de costo 9$ | maraca SanDisk | color rojo/negro| memoria 36GB |";
                                    _cantidadDeElementos++;
                                }
                                else if (_compra == "4")
                                {
                                    MontoDespues = 120; //_telefono
                                    _descripcion = "( Telefono )de costo 120$ |  maraca Redmi  |  color negro | memoria 128GB   |";
                                    _cantidadDeElementos++;
                                }
                                else if (_compra == "5")
                                {
                                    MontoDespues = 200; //_computador
                                    _descripcion = "( Computador (De escritorio) ) de costo 200$ | maraca Dell | color negro | memoria 250GB | ";
                                    _cantidadDeElementos++;
                                }
                                else if (_compra    == "6")
                                {
                                    MontoDespues = 40; //_smartwatch
                                    _descripcion = "(Smartwatch )  de costo 40$ |  maraca sonic  | color verde |  memoria 38GB |";
                                    _cantidadDeElementos++;
                                }
                                else if (_compra == "7")
                                {
                                    MontoDespues = 100; // _impresora
                                    _descripcion = "Impresora  de costo 100$ |  maraca hp  | color blanco |";
                                    _cantidadDeElementos++;
                                }
                                else
                                {
                                    Console.WriteLine($"|   Esa numero de producto no se encuentra   |\n");// si el usuario coloca el número un producto no valido
                                    Console.WriteLine($"|   Precione enter para terminar    |\n");
                                    Console.ReadLine();
                                }
                                break;
                            //Tienda Productos de Software 
                            case "3":
                                Console.WriteLine("\n|__________| Tienda Productos de Software |________________|\n|              \n|  Producto         Precio en $|\n|\n| 1) Visual Studio|          4$|\n| 2) WinRAR|                 6$|\n| 3) Word|                   5$|\n| 4) Microsof Office|       12$|\n| 5) Exel|                   3$|\n| 6) Power Point|           10$|\n____________________________________________________________________|\n|\n|       Seleccione el número del articulo a comprar : ");
                                _compra = Console.ReadLine();
                                if (_compra == "1")
                                {
                                    MontoDespues = 4; // _visualStudio
                                    _descripcion = "( VisualStudio ) de costo 4$ | maraca microsoftOffice | licencia 2022|";
                                    _cantidadDeElementos++;
                                }
                                else if (_compra == "2")
                                {
                                    MontoDespues = 6; //_winRAR
                                    _descripcion = "( WinRAR ) de costo 6$ | maraca Windows | licencia 2021 |";
                                    _cantidadDeElementos++;
                                }
                                else if (_compra == "3")
                                {
                                    MontoDespues = 5;  //Word
                                    _descripcion = "( Word ) de costo 5$ | maraca MicrosoftOffice |licencia 2020 |";
                                    _cantidadDeElementos++;
                                }
                                else if (_compra == "4")
                                {
                                    MontoDespues = 12; //_microsoftOffice
                                    _descripcion = "( MicrosoftOffice ) de costo 12$ |  maraca MicrosoftOffice | licencia 2022 |";
                                    _cantidadDeElementos++;
                                }
                                else if (_compra == "5")
                                {
                                    MontoDespues = 3; //_exel
                                    _descripcion = "( Exel ); de costo 3$ | maraca MicrosoftOffice |licencia 2022|";
                                    _cantidadDeElementos++;
                                }
                                else if (_compra == "6")
                                {
                                    MontoDespues = 10; //_powerPoint
                                    _descripcion = "( PowerPoint ) de costo 10$ | maraca MicrosoftOffice |licencia 2022|";
                                    _cantidadDeElementos++;
                                }
                                else
                                {
                                    Console.WriteLine($"|   Esa numero de producto no se encuentra   |\n");// si el usuario coloca el número un producto no valido
                                    Console.WriteLine($"|   Precione enter para terminar    |\n");
                                    Console.ReadLine();

                                }
                                break;
                            default:
                                Console.WriteLine($"|   Esa categoria no se encuentra   |\n");// si el usuario coloca el número de una categoria no valida
                                Console.WriteLine($"|   Precione enter para terminar    |\n");
                                Console.ReadLine();
                                break;
                        }
                        
                        Monto = (MontoAnterior + MontoDespues);// monto total de compra 
                        MontoAnterior = MontoAnterior + MontoDespues;//asigno el valor para llevar un registro de la compra por el ciclo de repeticion 
                    }
                    else
                    {
                        Console.WriteLine($"|   Esa categoria no se encuentra   |\n"); // si el usuario coloca el número de una categoria no valida
                        Console.WriteLine($"|   Precione enter para terminar    |\n");
                        Console.ReadLine();
                    }
                }
            
                //llamando a la funcion llenar datos 
                Console.WriteLine(LlenarDatos(_descripcion, _cantidadDeElementos,Monto)); //mustra de precio , producto y caracteristicas
                ///me escanea para poder continuar con la compilación o finalizarla.
                ComparadorDeCiclo = Console.ReadLine();

                if (ComparadorDeCiclo == "1")
                {
                    _x = 1;             //para que el usuario siga comprando articulos
                    Articulo = _cantidadDeElementos;

                }
                else if (ComparadorDeCiclo != "1")
                {
                    _x = 0;     //me genera  finalizar la compra 
                }

            } while (_x != 0);
            return Monto;        //retorno el monto total de la compra 
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //                 3)Realice en su programa una función que llene las categorías de artículos con datos fijos para evitar pedirlos al usuario 
        //
        //Funcion para llenar Los Datos de las categorias   producto / monto / descripciones 
        public string LlenarDatos(string _descripcionNueva,int _cantidadDeElementosNueva, int _compraUsuario)
        {
            string cadena;
            cadena = ($"|\n|_____________________________________________________________|\n|\n     *Carrito de compra * Has Comprado {_descripcionNueva} Cantidad de compras: {_cantidadDeElementosNueva} | MONTO A PAGAR : {_compraUsuario}$|\n|\n|  Desea volver a comprar presione  1 y enter  |\n|  Si no desea comprar más presione 0 y enter  |");
            return cadena;
        }
        public int Articulo1(int Articulo)
        {
            Articulo = _cantidadDeElementos;
            return Articulo; //retorna el articulo que ingreso el comprador (cantidad de compra )
        }
    }
    /// <summary>
    //     4)La creación de un carrito de compras que servirá para calcular el costo de la factura a generar, debe permitir agregar y eliminar artículos a través del menú
    /// </summary>

    class Carrito :Menu   //clase base 
    {
        //Atributos
        private int _carritoCompra;// tendra el registro de la compra de la persona
        /*private int _carritoFantasma; // tendra un registro por si la persona borra algun producto del carrito no supe hacer lo de borrar articulos */
        private int _contadorDeCompra; // registro de la cantidad de productos de compra 
        
        //Property
        public int CarritoCompra { get; set; }
        public int ContadorDeCompra { get{return _contadorDeCompra; } set { _contadorDeCompra = Articulo; } }
        //Constructores 
        public Carrito()
        {
            _contadorDeCompra = Articulo;
            _carritoCompra =Monto;      //carrito de compras que servirá para calcular el costo de la factura generar,
            CarritoCompra = _carritoCompra;  // asignacion del monto total de la compra 
        }

        // Funcion del carrito de compras  para mandar el monto a la factura 
        
        //Metodos
        public int  CarritoDeCompras(int carrtitoFantasmaAnterior)
        {
            return CarritoCompra;   //retorno el moto total que vino del menu ,  para la enviar a la  clase factura 
        }
      
    }


    class Factura :Carrito// clase derivada
    {
        //Atributos 
        private string _factura;    //cadnea que tendra toda la factura 
        private string _destinatario; // nombre y apellidos del ususario se guardara aqui 
        private string _cedula; //cedula del destinatario se guardara aqui 
        private string _celularTelefono; //telefono del destinatario se gurdara aqui 
        private int _iva;       // como agragado el iva  para el final de la factura de costo 3$ (costo del envio)

        //Constructores 
        public Factura() 
        {
            _destinatario = "Sin Definir"; //para que no tenga datos la factura en un principio 
            _cedula = "Sin Definir ";
            _celularTelefono = "Sin Definir";
            _iva = 3; // le asigne este valor (gusto personal )
        }



        ///
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        ///         //
        //                         5)La inserción del intestatario de la factura y modificación de sus datos
        //Metodos
        public string  Facturacion(int valorMonto) 
        {
            string enunciado="      Ingrese su :";
            Console.WriteLine("\n*      Compra Finalizada*\n\n*        Inserción del destinatario de la factura y modificación de sus datos");
            Console.WriteLine($"\n{enunciado}Nombres y Apellidos: ");
            _destinatario = Console.ReadLine();
            Console.WriteLine($"{enunciado}Cedula: ");
            _cedula = Console.ReadLine();
            Console.WriteLine($"{enunciado}Telefono:");
            _celularTelefono = Console.ReadLine();
            string membrete = ($"\n\n                           ************************************************\n                           *      Republica Bolivariana de Venezuela      *\n                           *         Codigo:  003.29.634.375.             *\n                           *             TuProductoOnline                 *\n                           *              F A C T U R A                   *\n                           *______________________________________________*\n                           * Fecha : Febrero 2023                         *\n                           *______________________________________________*\n");
            _factura = ($"{membrete}                           *Cliente:{_destinatario}\n                           *C.I:{_cedula}\n                           *Celular:{_celularTelefono}\n                           *   Iva                                      {_iva}$*\n                           *   MONTO                                  {valorMonto}$*\n                           *______________________________________________*\n                           *TOTAL                                      {(valorMonto) + (_iva)}$* total +iva\n"); 
            return ImprimirFactura(_factura);   //retorno la impresion de la factura con todos los datos en ella, tanto los que recibio de la herencia de la clase carrito, como  los datos del destinatario 
        }
        ///
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///            
        //             6)La impresión de la factura con los cálculos correctos y los datos del cliente

        public string ImprimirFactura(string Factura) //paso como parametro la factura completa y la imprime 
        {
            Console.WriteLine($"{Factura}                           *______________________________________________*\n\n                           ************************************************\n\n                   !! Gracias por su compra TuProductoOnline siempre a tu servicio !!\n\n                           ************************************************\n\n");
            return Factura;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu comprador = new Menu();
            comprador.TuPoductoOline();
            comprador.Articulo1(comprador.Articulo);  //para la asignacion de los articulos en este objeto
            Factura comprador1 = new Factura();     // creo un obejeto de tipo figura 
            comprador1.Facturacion(comprador.Monto = comprador.Menu_Program(Console.ReadLine())); //relizo la corrida de ese objeto en el programa  pasando por las diferentes funciones 
            Console.ReadLine();
            /*
            Console.WriteLine($"ARTICULO VALOR : {comprador.Articulo1(comprador.Articulo)}");// evaluar el comportamiento de carrito en menu (control de cantidad de productos y monto que lleva el usuario de las compras  ) 
            */
        }
    }
}

    

    






            
        
    

