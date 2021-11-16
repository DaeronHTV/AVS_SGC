import { Component, NgModule, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Connaissance, ConnaissanceControllerService } from 'src/app/api';

@Component({
  selector: 'app-connaissance-details',
  templateUrl: './connaissance-details.component.html',
  styleUrls: ['./connaissance-details.component.scss']
})
export class ConnaissanceDetailsComponent implements OnInit {
  private idConnaissance : string;
  connaissance$: Observable<Connaissance>;
  connaissance: Connaissance = {};

  constructor(private route: ActivatedRoute, private router: Router, private coController: ConnaissanceControllerService) { 
    this.idConnaissance = this.route.snapshot.paramMap.get('id') ?? "";
    this.connaissance$ = this.coController.getConnaissanceUsingGET(this.idConnaissance);
    this.ngOnInit();
  }

  ngOnInit(): void {
    this.connaissance$ = this.coController.getConnaissanceUsingGET(this.idConnaissance);
  }

}
