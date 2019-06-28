import { getPageUrls } from "@/common/outsideInterfaces";
import { createRadioInput } from "@/dom/input";

export async function createPageLinkPanel(oldValue: string) {
  let urls = await getPageUrls();
  let el = document.createElement("div");
  let selectedItem!: string;
  let radios = urls.map(m => createRadioInput(m));
  radios.forEach(i => {
    i.radio.onclick = () => {
      radios.filter(f => f != i).forEach(f => f.setChecked(false));
      i.setChecked(true);
      selectedItem = i.getContent();
    };
    if (i.getContent() == oldValue) i.setChecked(true);
    el.appendChild(i.radio);
  });
  return {
    pageLinkPanel: el,
    getContent: () => selectedItem
  };
}
