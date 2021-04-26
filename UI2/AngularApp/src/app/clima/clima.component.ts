
import {  Component, OnInit } from '@angular/core';
import {ClimaService} from '../services/clima.service';
import { interval } from 'rxjs';
import { take } from 'rxjs/operators';


@Component({
  selector: 'app-clima',
  templateUrl: './clima.component.html',
  styleUrls: [ './clima.component.css' ],
  providers:[ClimaService]
})

export class AppClima  implements OnInit
{
  public Temperatura:number=1;
  public Kelvin:number=1;
  public Celcius:boolean;
  public error:boolean=false;


  constructor(private _ClimaService:ClimaService)
  {
    this.Celcius=true;
    const source = interval(180000);
    const subscribe = source.subscribe(val => this.GetClima());
  }
   ngOnInit()
   {
    this.GetClima();
   }

   ConvertirCelciusOrFahrenheit()
   {

     this.Celcius = !this.Celcius;
     this.KelvinTo();
   }

    KelvinTo()
    {
      if(this.Celcius)
      {
        this.Temperatura = this.Kelvin - 273.15;
      }
      else
      {
        this.Temperatura = (this.Kelvin - 273.15) * 9/5 + 32;
      }

    }
    GetClima()
    {
      this._ClimaService.Get().subscribe
      ( resp =>
       {
             if(resp.success)
             {
              this.Kelvin = resp.entity.main.temp;
              this.error=false;
             }
             else
             {
              this.error=true;
             }
             this.KelvinTo();
       },
       error =>
       {
        this.error=true;
       }

      );
    }
}
