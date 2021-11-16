import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppRoutingEnum } from './app-routing-enum';
import { AideComponent } from './component/aide/aide.component';
import { PageErrorComponent } from './component/base/page-error/page-error.component';
import { ConnectComponent } from './component/connect/connect.component';
import { ContactComponent } from './component/contact/contact.component';
import { HomeComponent } from './component/home/home.component';
import { OptionsComponent } from './component/options/options.component';
import { CompetenceComponent } from './component/parametrage/competence/competence.component';
import { ConnaissanceDetailsComponent } from './component/parametrage/connaissance/connaissance-details/connaissance-details.component';
import { ConnaissanceComponent } from './component/parametrage/connaissance/connaissance.component';
import { DonneespersoComponent } from './component/reglement/donneesperso/donneesperso.component';
import { MentionslegalesComponent } from './component/reglement/mentionslegales/mentionslegales.component';

const routes: Routes = [
  {path: AppRoutingEnum.EMPTY, redirectTo: AppRoutingEnum.CONNECT, pathMatch: 'full'},
  {path: AppRoutingEnum.HOME, component: HomeComponent},
  {path: AppRoutingEnum.CONTACT, component: ContactComponent},
  {path: AppRoutingEnum.MENTIONSLEGALS, component: MentionslegalesComponent},
  {path: AppRoutingEnum.PERSODATA, component: DonneespersoComponent},
  {path: AppRoutingEnum.CONNECT, component: ConnectComponent},
  {path: AppRoutingEnum.OPTIONS, component: OptionsComponent},
  {path: AppRoutingEnum.HELP, component: AideComponent},
  {path: AppRoutingEnum.CONNAISSANCE, component: ConnaissanceComponent},
  {path: AppRoutingEnum.COMPETENCE, component: CompetenceComponent},
  {path: AppRoutingEnum.CONNAISSANCEDETAIL, component: ConnaissanceDetailsComponent},
  //A PLACER A LA FIN
  {path: AppRoutingEnum.NOTFOUND, component: PageErrorComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
