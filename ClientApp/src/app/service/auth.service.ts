import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { AngularFireAuth } from '@angular/fire/auth';
import { Injectable } from "@angular/core";
import { CompteInterface } from '../interface/firebdd';

@Injectable({
    providedIn: "root",
})
export class AuthService {

  user$: Observable<CompteInterface>;
  personnel: boolean = false;

    constructor(private afAuth: AngularFireAuth){
      this.user$ = this.afAuth.user.pipe(
        map(user => {
          this.personnel = user?.displayName ? false : true;
          return null;
        })
      );
    }
}