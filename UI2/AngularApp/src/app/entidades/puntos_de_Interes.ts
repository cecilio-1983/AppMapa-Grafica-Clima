export class Puntos_de_Interes
{

  public  id:number;
  public  latitud:number;
  public  longitud:number ;
  public  descripcion:string;
  public  venta:number ;
  public  idzona:number;
  public  zona:string;

  constructor(){
         this.id=0;
         this.latitud=0;
         this.longitud=0;
         this.descripcion='';
         this.idzona = 0;
         this.venta=0;
         this.zona='';
   }
}

