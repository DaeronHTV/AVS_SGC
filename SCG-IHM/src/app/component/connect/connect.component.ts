import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { AppRoutingEnum } from 'src/app/app-routing-enum';
import { ComponentManagerService } from 'src/app/service/component-manager.service';

@Component({
  selector: 'app-connect',
  templateUrl: './connect.component.html',
  styleUrls: ['./connect.component.scss']
})
export class ConnectComponent implements OnInit {
  private username: string = "test";
  private password: string = "test";

  constructor(private routeur: Router, public compManager: ComponentManagerService) { 
    this.compManager.seeMenu = true;
  }

  ngOnInit(): void {
    
  }

  public connect(user: string, pass: string): void{
    if(user === this.username && pass === this.password){
      this.compManager.seeMenu = false;
      this.routeur.navigateByUrl(AppRoutingEnum.HOME);
    }
    else{

    }
  }
}
