import { AfterViewInit, Component, OnInit } from '@angular/core';
import * as L from 'leaflet';
import {Puntos_de_Interes} from '../entidades/puntos_de_Interes';
import {PuntosDeInteresService} from '../services/puntos_de_interes.service';
import {Zonas}  from '../entidades/zonas';
import {ZonasService}  from '../services/zonas.service';


@Component({
  selector: 'app-map',
  templateUrl: './mapa.component.html',
  styleUrls: ['./mapa.component.css'],
  providers:[PuntosDeInteresService,ZonasService]
})


export class MapaComponent implements OnInit{
  private map:any;
  public lstPuntosInteres:Puntos_de_Interes[]=[];
  public lstZonas:Zonas[]=[];
  public error:boolean=false;

    constructor(private _puntosDeInteresService:PuntosDeInteresService,private _ZonasService:ZonasService )
    {


    }
    ngAfterContentChecked()
    {
      var myElement = document.getElementById("map");
      if(myElement && !this.map )
      {
          this.initMap();
          this.GetAll(this.map);
      }
    }
  ngOnInit()
  {
    this.GetAllZonas();
  }

   AddOnClick(maker:L.marker,item:Puntos_de_Interes)
   {


                  maker.bindPopup('<div>'+
                                    '<p><b>Id:'+ item.id +'</p><p> Nombre: '+ item.descripcion+'</b></p>'+
                                    '<p><b> Venta: $  '+ item.venta +'</b>'+'</p>' +
                                    '<p><b> Zona:' + this.GetNombreZona(item.idzona) +'</b></p></div>'
                                    );


   }
  private GetAll(map:L.map)
  {
    this._puntosDeInteresService.GetAll().subscribe(data =>{
       this.lstPuntosInteres = data.entity;
       for (let i=0; i < this.lstPuntosInteres.length; i++)
       {
        const maker = L.marker([this.lstPuntosInteres[i].latitud,this.lstPuntosInteres[i].longitud]).addTo(map);
        this.AddOnClick(maker,this.lstPuntosInteres[i]);
        this.error=false;
       }
      }, error=>
      {
       console.log(error);
       this.error=true;
      });

  }

  private GetNombreZona(IdZona):any
  {
    var item73 = this.lstZonas.filter(function(item) {
      return item.id === IdZona;
    })[0];
    return item73.descripcion;
  }
  private GetAllZonas()
  {
    this._ZonasService.GetAll().subscribe(data=>{
     this.lstZonas = data.entity;
     }, error=>
     {
      console.log(error);
     });
  }
  private initMap()
  {
    const tiles =  L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
    {
      attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
     });
     this.map = L.map('map').setView([19.580940,-99.25405],15)

     tiles.addTo(this.map);
  }
}
