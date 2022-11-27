$(document).ready(() => {
    ModalInitial();

    function ModalInitial() {
        var $modals = $('div[data-modal]');
        $($modals).hide();
        var $modal;
        var $openModals = $('[data-modal-open]');
        $openModals.click((e) => {
            e.preventDefault();
            var clickedModalId = e.target.getAttribute('id');
            $modal = $(`[data-modal="${clickedModalId}"]`);
            $($modal).show();
            var dataParts = $($modal).find('[data-part-name]');
            var listOfParts = GetElementDataPartName(dataParts);
            var activePart = DataPartMakeFirstActive(listOfParts);
            MakeProgress(listOfParts, activePart);
            MakeButtonDisableActive(listOfParts, activePart);
            ClickedModalButton(listOfParts, activePart);
        });

        var closeModalBtn = $('#close-modal');
        $(closeModalBtn).click((e) => {
            e.preventDefault();
            $($modal).hide();
            $modal = null;
            console.log($modal);
        });
        function GetElementDataPartName(element) {
            var listOfPartName = [];
            $(element).each((index, item) => {
                console.log($(item).attr('data-part-name'));
                listOfPartName.push($(item).attr('data-part-name'));
            });
            return listOfPartName;
        }
        function DataPartMakeFirstActive(listOfParts = []) {
            var firstpartName = listOfParts[0];
            var firstDataElement = $(`[data-part-name="${firstpartName}"]`);
            $(firstDataElement).addClass('active-part');
            return firstpartName;
        }
        function MakeProgress(listOfPartName, activePart) {
            var listOfActiveDataProgress = [];
            if (
                document.querySelector('.show-progress').childElementCount == 0
            ) {
                $(listOfPartName).each((index, item) => {
                    var element = document.createElement('div');
                    element.setAttribute('data-progress-name', item);
                    element.innerHTML = `<p>${item}</p>`;
                    console.log(activePart, item);
                    if (activePart == item) {
                        element.className = 'active-part-progress';
                    }
                    document
                        .querySelector('.show-progress')
                        .appendChild(element);
                    listOfActiveDataProgress.push(element);
                });
            }
            return listOfActiveDataProgress;
        }
        function MakeButtonDisableActive(listOfPartName = [], activePart) {
            var previousBtn = $('#previous-modal-btn');
            var nextBtn = $('#next-modal-btn');
            if (listOfPartName[0] == activePart) {
                $(previousBtn).prop('disabled', true);
            }
            if (listOfPartName.length <= 1) {
                $(nextBtn).prop('disabled', true);
            }
        }
        function ClickedModalButton(listOfPartName = [], activePart) {
            console.log('girdi');
            var previousBtn = $('#previous-modal-btn');
            var nextBtn = $('#next-modal-btn');
            var oldActivePart = activePart;
            var oldActivePartIndex = listOfPartName.indexOf(oldActivePart);
            var lengthOfListOfPart = listOfPartName.length;

            $(nextBtn).on('click', () => {
                if (listOfPartName[oldActivePartIndex + 1]) {
                    console.log('old active part index', oldActivePartIndex);
                    var newActivePartIndex = oldActivePartIndex + 1;
                    var newActivePart = listOfPartName[newActivePartIndex];
                    console.log(newActivePart);
                    $(`[data-progress-name="${oldActivePart}"]`).toggleClass(
                        'active-part-progress'
                    );
                    $(`[data-progress-name="${newActivePart}"]`).toggleClass(
                        'active-part-progress'
                    );
                    $(`[data-part-name="${oldActivePart}"]`).toggleClass(
                        'active-part'
                    );
                    $(`[data-part-name="${newActivePart}"]`).toggleClass(
                        'active-part'
                    );

                    $(previousBtn).prop('disabled', false);
                    oldActivePart = newActivePart;
                    oldActivePartIndex = newActivePartIndex;

                    if (newActivePartIndex == lengthOfListOfPart - 1) {
                        $(nextBtn).prop('disabled', true);
                    }
                }
            });

            $(previousBtn).on('click', () => {
                if (listOfPartName[oldActivePartIndex - 1]) {
                    console.log('old active part index', oldActivePartIndex);
                    var newActivePartIndex = oldActivePartIndex - 1;
                    var newActivePart = listOfPartName[newActivePartIndex];

                    console.log('new active part index', newActivePartIndex);
                    $(`[data-progress-name="${oldActivePart}"]`).toggleClass(
                        'active-part-progress'
                    );
                    $(`[data-progress-name="${newActivePart}"]`).toggleClass(
                        'active-part-progress'
                    );
                    $(`[data-part-name="${oldActivePart}"]`).toggleClass(
                        'active-part'
                    );
                    $(`[data-part-name="${newActivePart}"]`).toggleClass(
                        'active-part'
                    );

                    $(nextBtn).prop('disabled', false);
                    oldActivePart = newActivePart;
                    oldActivePartIndex = newActivePartIndex;

                    if (newActivePartIndex == 0) {
                        $(previousBtn).prop('disabled', true);
                    }
                }
            });
        }
    }
});
