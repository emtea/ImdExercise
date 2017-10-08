import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { ShowReelsComponent } from './components/show-reels/show-reels.component';
import { AddReelComponent } from './components/add-reel/add-reel.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        AddReelComponent,
        ShowReelsComponent,
        HomeComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'show-reels', component: ShowReelsComponent },
            { path: 'add-reel', component: AddReelComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
