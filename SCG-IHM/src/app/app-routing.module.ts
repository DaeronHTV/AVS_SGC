import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppRoutingEnum } from './app-routing-enum';
import { AideComponent } from './component/aide/aide.component';
import { PageErrorComponent } from './component/base/page-error/page-error.component';
import { ConnectComponent } from './component/connect/connect.component';
import { ContactComponent } from './component/contact/contact.component';
import { HomeComponent } from './component/home/home.component';
import { ParametreComponent } from './component/parametre/parametre.component';
import { DonneespersoComponent } from './component/reglement/donneesperso/donneesperso.component';
import { MentionslegalesComponent } from './component/reglement/mentionslegales/mentionslegales.component';

const routes: Routes = [
  {path: AppRoutingEnum.EMPTY, redirectTo: AppRoutingEnum.CONNECT, pathMatch: 'full'},
  {path: AppRoutingEnum.HOME, component: HomeComponent},
  {path: AppRoutingEnum.CONTACT, component: ContactComponent},
  {path: AppRoutingEnum.MENTIONSLEGALS, component: MentionslegalesComponent},
  {path: AppRoutingEnum.PERSODATA, component: DonneespersoComponent},
  {path: AppRoutingEnum.CONNECT, component: ConnectComponent},
  {path: AppRoutingEnum.PARAMETER, component: ParametreComponent},
  {path: AppRoutingEnum.HELP, component: AideComponent},
  {path: AppRoutingEnum.NOTFOUND, component: PageErrorComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
