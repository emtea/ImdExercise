import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'show-reels',
    templateUrl: './show-reels.component.html'
})
export class FetchDataComponent {
    public showReels: ShowReel[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Reels').subscribe(result => {
            this.showReels = result.json() as ShowReel[];
        }, error => console.error(error));
    }
}

interface ShowReel {
    id: string;
    name: string;
    vStandard: string;
    vStandardString: string;
    vDefinition: string;
    vDefinitionString: string;
    durationString: string;
}
