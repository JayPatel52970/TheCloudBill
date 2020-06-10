import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AccountComponent } from './account/account.component';
import { AppComponent } from './app/app.component';


const routes: Routes = [ 

  {
    path: 'account',
    loadChildren: () => import('./account/account.module').then(m => m.AccountModule)
    //component: AccountComponent
  },
  {
    path: 'app',
    loadChildren: () => import('./app/app.module').then(m => m.AppModule)

    //component: AppComponent
  }


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class RootRoutingModule { }
