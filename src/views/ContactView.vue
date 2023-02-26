<script setup lang="ts">
import ContentLayout from '@/components/ContentLayout.vue';
import { reactive } from 'vue';
import { required, email } from '@vuelidate/validators';
import useVuelidate from '@vuelidate/core';

const model = reactive({
    name: '',
    emailAddress: '',
    phone: '',
    message: ''
});

const rules = {
    name: { required },
    emailAddress: { required, email },
    message: { required }
};

const v$ = useVuelidate(rules, model);

</script>

<template>
    <ContentLayout>
        <template #header>Contact</template>
        <template #page-content>
            <div class="d-flex flex-row">
                <div class="d-flex flex-column w-50 fs-4">
                    <div class="ms-1">
                        <h3>Damien Smith</h3>
                    </div>
                    <div class="ms-1 mb-1">
                        Phone: 
                        <a href="tel:0403291191">0403 291 191</a>
                    </div>
                    <div class="ms-1 mb-1">
                        Email 
                        <a href="mailto:southpacificseaurchins@gmail.com" target="_blank">southpacificseaurchins@gmail.com</a>
                    </div>
                    <div class="mb-1">
                        <a href="https://instagram.com/south_pacific_sea_urchins" class="social-icon instagram" target="_blank"></a>
                    </div>
                    <div class="mb-3"></div>
                    <div class="mb-3"></div>
                    <div class="mb-3"></div>
                </div>
                <!-- <div class="d-flex flex-column w-50">
                    <form>
                        <div class="mb-3">
                            <input type="text" class="form-control" id="nameInput" placeholder="Name *" v-model="model.name" :class="{ 'error' : v$.name.$error }">
                        </div>
                        <div class="mb-3">
                            <input type="tel" class="form-control" id="phoneInput" placeholder="Contact number (optional)" v-model="model.phone">
                        </div>
                        <div class="mb-3">
                            <input type="email" class="form-control" id="emailAddressInput" placeholder="Email *" v-model="model.emailAddress" :class="{ 'error' : v$.emailAddress.$error }">
                        </div>
                        <div class="mb-3">
                            <textarea class="form-control" id="messageInput" placeholder="Message *" v-model="model.message" :class="{ 'error' : v$.message.$error }"></textarea>
                        </div>
                    </form>
                    <button class="form-control btn btn-info" type="submit" @click="sendEmail">Send</button>
                </div> -->
            </div>

        </template>
    </ContentLayout>
</template>

<style lang="scss" scoped>
.error {
    border: 1px solid var(--bs-red);
}
</style>