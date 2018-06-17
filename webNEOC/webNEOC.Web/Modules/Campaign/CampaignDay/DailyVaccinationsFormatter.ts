namespace webNEOC.Campaign {

    @Serenity.Decorators.registerFormatter()
    export class DailyVaccinationsFormatter implements Slick.Formatter {

        format(ctx: Slick.FormatterContext) {

            if ((ctx.value == null || String(ctx.value).length == 0)) {
                return ctx.value;
            }



            var testNumber: number = ctx.value;

            if (testNumber == 0)
                return "<div style='height:100%; color: #ff0000;'><strong>" + testNumber + '</strong></div>';
            return "<div style='height:100%;'>" + testNumber + '</div>';
        }
    }
}