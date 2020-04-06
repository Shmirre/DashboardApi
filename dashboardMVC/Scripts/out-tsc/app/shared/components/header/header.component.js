import { __decorate, __metadata } from "tslib";
import { Component, EventEmitter, Output } from '@angular/core';
let HeaderComponent = class HeaderComponent {
    constructor() {
        this.toggleSideBarForMe = new EventEmitter();
    }
    ngOnInit() { }
    toggleSideBar() {
        this.toggleSideBarForMe.emit();
        setTimeout(() => {
            window.dispatchEvent(new Event('resize'));
        }, 300);
    }
};
__decorate([
    Output(),
    __metadata("design:type", EventEmitter)
], HeaderComponent.prototype, "toggleSideBarForMe", void 0);
HeaderComponent = __decorate([
    Component({
        selector: 'app-header',
        templateUrl: './header.component.html',
        styleUrls: ['./header.component.scss']
    }),
    __metadata("design:paramtypes", [])
], HeaderComponent);
export { HeaderComponent };
//# sourceMappingURL=header.component.js.map