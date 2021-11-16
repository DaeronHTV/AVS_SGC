import { AfterContentChecked, AfterViewChecked, AfterViewInit, ChangeDetectionStrategy, ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Connaissance, ConnaissanceControllerService } from 'src/app/api';
import { ToastService } from 'src/app/service/manager/toast.service';

@Component({
  selector: 'app-connaissance',
  templateUrl: './connaissance.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush,
  styleUrls: ['./connaissance.component.scss']
})
export class ConnaissanceComponent {
  listConnaissance: Connaissance[] = [];
  loading: boolean = true;


  constructor(private apiConnaissance: ConnaissanceControllerService, private toast: ToastService, private cd: ChangeDetectorRef) { 
    this.apiConnaissance.getAllConnaissanceUsingGET(undefined, true).subscribe(
      (result) => {
        this.listConnaissance = result;
        this.loading = false;
        console.log(result);
        this.cd.detectChanges();
      },
      (error) => {
        this.listConnaissance = [];
        this.toast.showError(error.message, "Erreur lors de récupération des connaissances");
        this.loading = false;
      }
    );
  } 

  get isListFilled(): boolean{ return this.listConnaissance.length > 0; }
  get isLoading(): boolean { return this.loading; }

}
