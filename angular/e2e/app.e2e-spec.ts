import { APIClubTemplatePage } from './app.po';

describe('APIClub App', function() {
  let page: APIClubTemplatePage;

  beforeEach(() => {
    page = new APIClubTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
