import { __decorate, __metadata } from "tslib";
import { Component } from '@angular/core';
let DefaultComponent = class DefaultComponent {
    constructor() {
        this.sideBarOpen = true;
    }
    ngOnInit() {
    }
    sideBarToggler(event) {
        this.sideBarOpen = !this.sideBarOpen;
    }
};
DefaultComponent = __decorate([
    Component({
        selector: 'app-default',
        templateUrl: './default.component.html',
        styleUrls: ['./default.component.scss']
    }),
    __metadata("design:paramtypes", [])
], DefaultComponent);
export { DefaultComponent };
//# sourceMappingURL=default.component.js.map