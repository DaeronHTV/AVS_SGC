import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ComponentManagerService {
  private seemenu: boolean;
  private _version: string;

  constructor() { 
    this.seemenu = true;
    this._version = "";
  }

  get seeMenu(){ return this.seemenu;}
  set seeMenu(value: boolean){ this.seemenu = value;}

  get version(){ return this._version; }
  set version(value: string){ this._version = value; }
}
