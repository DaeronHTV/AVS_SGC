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

  /**
   * @description Constructeur du component
   * @param apiData Controller pour récupérer les données et configuration de l'api
   * @param compManager Service permettant de partager les données sur l'ensemble des component
   * @param toast ToastService permettant d'afficher les erreurs ou infos sous la forme d'un tooltips
   * @param routeur Service permettant la gestion des routes de l'application
   */
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

  /**
   * @description Permet de gérer l'affichage du menu en fonction
   * du component affiché
   * @since 15/11/2021
   * @author Avanzino.A
   */
  private checkComponent(): void{
    this.routeur.events.subscribe((event) => {
      if(event instanceof RouterEvent){
        this.seeMenu = event.url === "/" || event.url === '/'+AppRoutingEnum.CONNECT ? false : true;
      }
    });
  }
}
