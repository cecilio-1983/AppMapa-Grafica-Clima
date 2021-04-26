import {Injectable} from '@angular/core';
import {HttpClient,HttpEvent, HttpInterceptor, HttpHandler, HttpRequest} from '@angular/common/http';
import { Observable } from 'rxjs';
import {GLOBAL} from '../services/global';

@Injectable()

export class ClimaService
{
  public url:string;
  constructor( public _http:HttpClient)
    {
      this.url = GLOBAL.url  +'Clima';
    }
    Get():Observable<any>
    {
      const headers = { 'content-type': 'application/json'};
      const body=JSON.stringify('');
      return this._http.get(this.url+'?ciudad=Mexico&key=b0e8e7140ac976fa104961be36da697e');
    }
}
