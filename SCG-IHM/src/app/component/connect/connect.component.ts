import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AppRoutingEnum } from 'src/app/app-routing-enum';

@Component({
  selector: 'app-connect',
  templateUrl: './connect.component.html',
  styleUrls: ['./connect.component.scss']
})
export class ConnectComponent implements OnInit {
  private username: string = "test";
  private password: string = "test";

  constructor(private routeur: Router) { }

  ngOnInit(): void {

  }

  public connect(user: string, pass: string): void{
    if(user === this.username && pass === this.password){
      this.routeur.navigateByUrl(AppRoutingEnum.HOME);
    }
    else{

    }
  }
}
