import { ChangeDetectionStrategy, Component } from '@angular/core';
import { Router, RouterEvent } from '@angular/router';
import { ApiControllerService } from './api';
import { AppRoutingEnum } from './app-routing-enum';
import { ComponentManagerService } from './service/manager/component-manager.service';
import { ToastService } from './service/manager/toast.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
  providers: [ApiControllerService]
})
export class AppComponent{
  seeMenu: boolean = true;

  constructor(private apiData: ApiControllerService, public compManager: ComponentManagerService, 
    private toast: ToastService, private routeur: Router){
    if(this.compManager.version === ""){
      this.apiData.getVersionUsingGET(undefined, true).subscribe(
        (res) => { this.compManager.version = res; },
        (error) => {
          this.toast.showError(error.message, "Http Failure !");
          this.compManager.version = "1.0";
        }
      );
    }
    this.checkComponent();
  }

  private checkComponent(): void{
    this.routeur.events.subscribe((event) => {
      if(event instanceof RouterEvent){
        console.log(event.url);
        this.seeMenu = event.url === "/" || event.url === '/'+AppRoutingEnum.CONNECT ? false : true;
      }
    });
  }
}
