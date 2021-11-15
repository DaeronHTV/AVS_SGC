import { Component } from '@angular/core';
import { ApiControllerService, CompteControllerService } from './api';
import { ComponentManagerService } from './service/manager/component-manager.service';
import { ToastService } from './service/manager/toast.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [ApiControllerService]
})
export class AppComponent{
  title = 'SCG-IHM';

  constructor(private apiData: ApiControllerService, public compManager: ComponentManagerService, 
    private toast: ToastService){
    /*if(this.compManager.version === ""){
      this.apiData.getVersionUsingGET(undefined, true).subscribe(
        (res) => {
          //console.log(res);
          this.compManager.version = res;
        },
        (error) => {
          this.toast.showError(error.message, "Http Failure !");
          this.compManager.version = "1.0";
        }
      );
    }*/
  }
}
