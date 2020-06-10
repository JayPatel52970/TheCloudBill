import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { RootRoutingModule  } from './root-routing.module';
import { RootComponent} from './root.component';
import { AccountComponent } from './account/account.component';

@NgModule({
  declarations: [
    RootComponent,
    AccountComponent
  ],
  imports: [
    BrowserModule,
    RootRoutingModule
  ],
  providers: [],
  bootstrap: [RootComponent]
})
export class RootModule { }
