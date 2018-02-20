/**
 * This spec is to test the reload function
 */

describe('ReLoad 60 Seconds', function () {
    it('LoadTest', function () {

        expect(reLoad()).toEqual('test');

    });
});
/*This spec is to test Search*/
describe('Search', function () {
    it('FiltertweetId', function () {
        FilterTweets();
        var a = document.getElementById("FiltertweetId");
        expect(a.is(":hidden")).toBe(true);


    });
});