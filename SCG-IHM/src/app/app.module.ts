import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

//Gestion API
import { HttpClientModule } from '@angular/common/http';
import { ApiModule, BASE_PATH } from './api';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [{ provide: BASE_PATH, useValue: 'http://localhost:8080' }],
  bootstrap: [AppComponent]
})
export class AppModule { }
