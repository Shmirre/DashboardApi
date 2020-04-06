import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DefaultComponent } from './default.component';
import { DashboardComponent } from '../../modules/dashboard/dashboard.component';
import { RouterModule } from '@angular/router';
import { AdditionalInfoComponent } from '../../modules/additional-info/additional-info.component';
import { SharedModule } from '../../shared/shared.module';
import { MatSidenavModule } from '@angular/material/sidenav'
import { MatDividerModule } from '@angular/material/divider';


@NgModule({
  declarations: [
    DefaultComponent,
    DashboardComponent,
    AdditionalInfoComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    SharedModule,
    MatSidenavModule,
    MatDividerModule
  ]
})
export class DefaultModule { }
