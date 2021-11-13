import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ComponentManagerService {
  private seemenu: boolean;

  constructor() { 
    this.seemenu = false;
  }

  get seeMenu(){ return this.seemenu;}
  set seeMenu(value: boolean){ this.seemenu = value;}
}
