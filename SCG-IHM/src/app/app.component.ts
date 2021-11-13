import { Component, OnInit } from '@angular/core';
import { ApiControllerService } from './api';
import { ComponentManagerService } from './service/component-manager.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [ApiControllerService]
})
export class AppComponent implements OnInit{
  title = 'SCG-IHM';

  constructor(private apiData: ApiControllerService, public compManager: ComponentManagerService){
    this.apiData.getVersionUsingGET().subscribe(
      (res) => {
        console.log(res);
      }
    );
  }

  ngOnInit(): void {
    this.apiData.getVersionUsingGET().subscribe(
      (res) => {
        console.log(res);
      }
    );
  }
}
