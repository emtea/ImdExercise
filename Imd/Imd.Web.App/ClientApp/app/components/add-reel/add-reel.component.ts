import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { ShowReel } from '../../models/showReel';

@Component({
    selector: 'add-reel',
    templateUrl: './add-reel.component.html'
})
export class AddReelComponent {

    private http: Http;
    private url: String;
    public showReel: ShowReel;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.http = http;
        this.url = baseUrl;
    }
}


