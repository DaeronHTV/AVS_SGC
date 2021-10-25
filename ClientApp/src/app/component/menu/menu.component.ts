import { CompteInterface } from 'src/app/interface/firebdd';
import { AppRoutingEnum } from './../../app-routing.enum';
import { Component } from '@angular/core';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent {

  AppRoutingEnum = AppRoutingEnum;
  contact: CompteInterface = null;

  constructor() { 
    
  }

}
